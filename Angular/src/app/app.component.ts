import { Component, OnInit, Input } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AbcService } from './AbcService';
import { IAbcData } from './AbcService';
import { NgModule } from '@angular/core';
import { AppleComponent } from './apple.component';
import { BananaComponent } from './banana.component';
import { CarrotComponent } from './carrot.component';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
	constructor(private abcService: AbcService) {}
	callResult: any = null;
	pending: any = null;
	boolDisplay: any = null;
	personId: any = null;
	
	async getPerson(): Promise<IAbcData> {
		try{
		this.pending = true;
		this.callResult = await this.abcService.GetAbcData(this.personId);
		this.boolDisplay = this.callResult.result;
		this.pending = false;
		}catch(error){
			alert(error);
		}
		return this.personId;
	}
}
