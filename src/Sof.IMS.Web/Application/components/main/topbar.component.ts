import {Component, OnInit, OnDestroy, HostListener}		from "@angular/core";

@Component({
	selector: 'topbar',
	templateUrl: "views/main/topbar.html",
	host: {
		'(document:keyup)' : 'onDocumentKeyUp($event)',
		'(window:resize)' : 'OnResizeWindow($event)'
	}
})

export class TopbarComponent implements OnInit, OnDestroy
{
	private 		mKey:			string;
	private 		mIsCollapse: 	boolean;

	/// Constructor
	constructor ()
	{
		/// Initialize Member Variables
		this.mIsCollapse = false;
	}

	OnResizeWindow (_resize: UIEvent) {
		var sample = _resize.view.innerHeight;
	}

	onDocumentKeyUp(ev: KeyboardEvent) {
		this.mKey = ev.key;
		var height = document.body.scrollHeight;
	}

	/// On Initialize
	ngOnInit ()
	{
	}

	/// Destructor
	ngOnDestroy ()
	{
	}
}