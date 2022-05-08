import { Injectable } from "@angular/core";
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot } from "@angular/router";
//import { Observable } from "rxjs";

@Injectable({
    providedIn: 'root',
})

export class RoutesGuard implements CanActivate {

    constructor(private router: Router) { }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean /*| Observable<boolean> | Promise<boolean>*/ {
        var authenticated = localStorage.getItem("User is authenticated");
        if (authenticated == "1") {
            return true;
        }
        this.router.navigate(['auth/login'], { queryParams: { returnUrl: state.url } })
        return false;
    }
}