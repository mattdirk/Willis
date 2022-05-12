import { Component, Input } from '@angular/core';
import { PickerModule } from '@ctrl/ngx-emoji-mart';

@Component({
  selector: 'apple',
  template: `<div style="color:red">apple</div>`//`<emoji-mart set='apple'></emoji-mart>`,//`<emoji-mart set='🍎'></emoji-mart>`
})
export class AppleComponent {}
