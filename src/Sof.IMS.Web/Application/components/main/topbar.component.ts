import {Component, OnInit, OnDestroy, HostListener, ElementRef, Renderer, ViewChild, AfterViewInit}		from "@angular/core";

@Component({
	selector: 'topbar',
	templateUrl: "views/main/topbar.html",
	host: {
		'(document:keyup)' : 'onDocumentKeyUp($event)',
		'(window:resize)' : 'OnResizeWindow($event)'
	}
})

export class TopbarComponent implements OnInit, OnDestroy, AfterViewInit
{
	private 		mKey:			string;
	private 		mIsCollapse: 	boolean;

	private			mRenderer:		Renderer;

	@ViewChild("topMenu")
	private 	_topbarMenu: ElementRef;

	/// Constructor
	constructor (_renderer: Renderer)
	{
		/// Initialize Member Variables
		this.mIsCollapse = true;
		this.mRenderer = _renderer;
	}

	ngAfterViewInit ()
	{
		//this.mRenderer.setElementClass (this.topbarElement.nativeElement, "topbar-user", false);
		//this.mRenderer.setElementClass (this.aboutElement.nativeElement, "active", true);
	}

	OnResizeWindow (_resize: Event) {
	}

	onDocumentKeyUp(ev: KeyboardEvent) {
		this.mKey = ev.key;
		var height = document.body.scrollHeight;
	}

	private OnClickToggle ()
	{
		this.mIsCollapse = !this.mIsCollapse;
		if (this.mIsCollapse == true) {
			this.mRenderer.setElementClass (this._topbarMenu.nativeElement, "topbar-menu-show", false);
			this.mRenderer.setElementClass (this._topbarMenu.nativeElement, "collapse", true);
		}
		else {
			this.mRenderer.setElementClass (this._topbarMenu.nativeElement, "collapse", false);
			this.mRenderer.setElementClass (this._topbarMenu.nativeElement, "topbar-menu-show", true);
			this.mRenderer.setElementClass (this._topbarMenu.nativeElement, "collapsing", true);
		}
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