import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import {LoginComponent} from  "./authentication/login/login.component"
import{RegisterUserComponent} from  "./authentication/register-user/register-user.component"
import { HomeComponent } from "./home/home.component";


const defaultRoutePath = "home";
const rootRoutes: Routes = [
    { path: "home", component: HomeComponent },
    { path: "login", component: LoginComponent },
    { path: "registeruser", component: RegisterUserComponent },
    // { path: "login", component: LoginComponent },  
    { path: "**", redirectTo: "/home" }
];

@NgModule({
    imports: [
        RouterModule.forRoot(
            rootRoutes,
            {
                enableTracing: true,
                relativeLinkResolution: 'legacy',
                scrollPositionRestoration: 'enabled',
                anchorScrolling: 'enabled',
                scrollOffset: [0, 64],
            }
        )
    ],
    exports: [
        RouterModule,
    ]
})
export class AppRoutingModule {
    getDefaultRoutePath() {
        return defaultRoutePath;
    }
}
