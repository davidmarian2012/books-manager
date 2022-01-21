import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appHoverBtn]'
})
export class HoverBtnDirective {

  constructor(
    public el: ElementRef,
  ) { }
  @HostListener('mouseenter') onMouseEnter() {
    this.highlight('rgb(63, 102, 122)');
  }
  @HostListener('mouseleave') onMouseLeave() {
    this.highlight('rgb(33, 122, 122)');
  }
  private highlight(color: string) {
    this.el.nativeElement.style.backgroundColor = color;
  }
}
