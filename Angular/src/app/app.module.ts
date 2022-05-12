import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { AbcService } from './AbcService';
import { AppleComponent } from './apple.component';
import { BananaComponent } from './banana.component';
import { CarrotComponent } from './carrot.component';

@NgModule({
  declarations: [
    AppComponent,
	AppleComponent,
	BananaComponent,
	CarrotComponent
  ],
  imports: [
    BrowserModule,
	FormsModule
  ],
  providers: [AbcService],
  bootstrap: [AppComponent]
})
export class AppModule { }
