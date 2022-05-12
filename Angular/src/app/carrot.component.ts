import { Component, Input } from '@angular/core';
import { PickerModule } from '@ctrl/ngx-emoji-mart';

@Component({
  selector: 'carrot',
  template: `<div style="color:orange">Carrot</div>`//`<emoji-mart set='carrot'></emoji-mart>`,//`<emoji-c e='🥕'></emoji-c>`,
})
export class CarrotComponent {}
