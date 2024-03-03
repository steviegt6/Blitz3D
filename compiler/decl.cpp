#include "std.h"
#include "decl.h"
#include "type.h"
#include <algorithm>

Decl::~Decl() {
}

DeclSeq::DeclSeq() {
}

void Decl::getName(char* buff) {
    int sz = name.size();
    memcpy(buff, name.data(), sz);
    buff[sz] = 0;
}

DeclSeq::~DeclSeq() {
    for (; decls.size(); decls.pop_back()) delete decls.back();
}

Decl* DeclSeq::findDecl(const std::string& s) {
    std::vector<Decl*>::iterator it;
    for (it = decls.begin(); it != decls.end(); ++it) {
        if ((*it)->name == s) return *it;
    }
    return 0;
}

Decl* DeclSeq::findDecl(const std::string& s, int params) {
    if (FuncOverrideMapper.contains(s)) {
        Decl* d = this->findDecl(s);
        if (d->type->funcType()->params->size() == params) return d;
        std::for_each(FuncOverrideMapper[s].begin(), FuncOverrideMapper[s].end(), [this, params, &d](std::tuple<std::string, int, int> func) {
            if (std::get<1>(func) == params) {
                d= this->findDecl(std::get<0>(func));
                return d;
            }
            if ((std::get<1>(func) + std::get<2>(func)) >= params) d = this->findDecl(std::get<0>(func));
            });
        return d;
    }
    return this->findDecl(s);
}

Decl* DeclSeq::insertDecl(const std::string& s, Type* t, int kind, ConstType* d) {
    if (kind & DECL_FUNC) {
        FuncType* func = t->funcType();
        if (Decl* d1 = findDecl(s)) {
            if (d1->type->funcType()->params->size() == func->params->size()) return 0;
            const std::string newFuncName = "blitz_"s + s + to_string(FuncOverrideMapper[s].size());
            const int paramNoDefVal = std::count_if(func->params->decls.begin(), func->params->decls.end(), [](Decl* d) {
                return d->defType == 0;
                });

            if (std::count_if(FuncOverrideMapper[s].begin(), FuncOverrideMapper[s].end(), [func](auto tuple) {
                return std::get<1>(tuple) + std::get<2>(tuple) == func->params->size();
                }))return 0;
            Decl* decl = new Decl(newFuncName, t, kind, d);
            FuncOverrideMapper[s].push_back(std::make_tuple(newFuncName, paramNoDefVal, func->params->size() - paramNoDefVal));
            decls.push_back(decl);
            return decls.back();
        }
        decls.push_back(new Decl(s, t, kind, d));
        return decls.back();
    }
    if (findDecl(s)) return 0;
    decls.push_back(new Decl(s, t, kind, d));
    return decls.back();
}