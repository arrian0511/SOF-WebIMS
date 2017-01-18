import {NgModule} 				from "@angular/core";
import {HttpModule} 			from "@angular/http";
import {BrowserModule} 			from "@angular/platform-browser";
import {FormsModule, ReactiveFormsModule} from "@angular/forms";
import "rxjs/Rx";

import * as spinner 			from 'ng-spin-kit/dist/spinners';
import {AppService} 			from "../services/app.service";
import {AppComponent} 			from "../components/app.component";
import {Highlight} 				from "../pipes/highlight.pipe";

@NgModule({
	declarations: [
		AppComponent,
		Highlight,
		spinner.CircleComponent
	],
	imports: [
		BrowserModule,
		HttpModule,
		FormsModule,
		ReactiveFormsModule,
	],
	providers: [
		AppService
	],
	bootstrap: [
		AppComponent
	]
})

///
/// Application Module
///
export class AppModule { }