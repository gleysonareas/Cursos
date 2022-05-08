import { AppRoutingModule, routedComponents } from './app-routing.module';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { SharedModule } from 'src/shared/shared.module';
import { PagesModule } from 'src/pages/pages.module';
import { AuthModule } from 'src/auth/auth.module';
import { BrowserModule } from '@angular/platform-browser';

@NgModule({
  declarations: [
    ...routedComponents
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    AppRoutingModule,
    AuthModule,
    PagesModule,
    SharedModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
