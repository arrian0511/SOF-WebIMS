/// <reference path="../typings/globals/core-js/index.d.ts" />

import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { AppModule } from "./modules/app.module";

const platform = platformBrowserDynamic();
platform.bootstrapModule(AppModule);