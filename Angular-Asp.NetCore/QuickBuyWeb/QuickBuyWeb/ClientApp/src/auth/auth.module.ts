import { NgModule } from "@angular/core";
import { SharedModule } from "src/shared/shared.module";
import { AuthRoutingModule, routedAuthComponents } from './auth-routing.module';

@NgModule({
    imports: [
        AuthRoutingModule,
        SharedModule,
    ],
    declarations: [
        ...routedAuthComponents,
    ]
})

export class AuthModule { }