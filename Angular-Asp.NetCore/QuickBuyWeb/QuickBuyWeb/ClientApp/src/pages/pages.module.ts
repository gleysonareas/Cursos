import { PagesRoutingModule, routedPagesComponents } from './pages-routing.module';
import { NgModule } from "@angular/core";
import { SharedModule } from 'src/shared/shared.module';

@NgModule({
    declarations: [
        ...routedPagesComponents,
    ],
    imports: [
        PagesRoutingModule,
        SharedModule,
    ],
    exports: [
        ...routedPagesComponents,
    ]
})

export class PagesModule { }