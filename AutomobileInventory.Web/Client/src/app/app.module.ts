import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { CreateComponent } from './create/create.component';
import { IndexComponent } from './index/index.component';
import { DetailComponent } from './detail/detail.component';
import { EditComponent } from './edit/edit.component';

const routes: Routes = [{ path: 'create', component: CreateComponent },
{ path: 'detail/:id', component: DetailComponent },
{ path: 'index', component: IndexComponent },
{ path: 'edit', component: EditComponent }];
@NgModule({
  declarations: [
    AppComponent,
    CreateComponent,
    IndexComponent,
    DetailComponent,
    EditComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }
