export class LinkedList<TElement> {
  elements: TElement[];
  first?: TElement;
  last?: TElement;

  constructor() {
    this.elements = [];
  }

  public push(element: TElement) {
    this.elements.push(element);
  }

  public pop(): TElement | undefined {
    return this.elements.pop();
  }

  public shift(): TElement | undefined {
    return this.elements.shift();
  }

  public unshift(element: TElement) {
    return this.elements.unshift(element);
  }

  public delete(element: unknown) {
    this.elements = this.elements.filter((item) => item !== element);
  }

  public count(): number {
    return this.elements.length;
  }
}
