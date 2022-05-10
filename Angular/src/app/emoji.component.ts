import { Component, Input } from '@angular/core';

@Component({
  selector: 'emoji-c',
  template: `<h1>{{e}}</h1>`,
})
export class EmojiComponent {
  @Input() e: string = '';
}
