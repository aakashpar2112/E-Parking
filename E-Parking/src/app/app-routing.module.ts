import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutusComponent } from './aboutus/aboutus.component';
import { BookingComponent } from './booking/booking.component';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { AdminComponent } from './admin/admin.component';
import { ServiceproviderComponent } from './serviceprovider/serviceprovider.component';
import { CustomerComponent } from './customer/customer.component';
import { BookingformComponent } from './bookingform/bookingform.component';
const routes: Routes = [
  { path: "aboutus", component: AboutusComponent },
  { path: "home", component: HomeComponent },
  { path: "", component: HomeComponent },
  { path: "booking", component: BookingComponent },
  { path: "register", component: RegisterComponent },
  { path: "login", component: LoginComponent },
  { path: "admin", component: AdminComponent },
  { path: "serviceprovider", component: ServiceproviderComponent },
  { path: "customer", component: CustomerComponent },
  { path: "book", component: BookingformComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
