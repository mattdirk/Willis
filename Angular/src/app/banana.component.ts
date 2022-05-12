import { Component, Input } from '@angular/core';
import { PickerModule } from '@ctrl/ngx-emoji-mart';

@Component({
  selector: 'banana',
  template: `<div style="color:yellow">banana</div>`//`<emoji-mart set='banana'></emoji-mart>`,//`<emoji-c e='🍌'></emoji-c>`,
})
export class BananaComponent {}
