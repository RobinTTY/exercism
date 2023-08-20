export class Clock {
  public hours: number;
  public minutes: number;

  constructor(hour: number, minute?: number) {
    this.hours = hour;
    this.minutes = minute ?? 0;
    this._normalizeClock();
  }

  public toString(): string {
    return `${zeroPad(this.hours, 2)}:${zeroPad(this.minutes, 2)}`;
  }

  public plus(minutes: number): Clock {
    this.minutes += minutes;
    this._normalizeClock();
    return this;
  }

  public minus(minutes: number): Clock {
    this.minutes -= minutes;
    this._normalizeClock();
    return this;
  }

  public equals(other: Clock): boolean {
    return this.hours === other.hours && this.minutes === other.minutes;
  }

  private _normalizeClock() {
    let minutes = this.minutes % 60;
    let hourChange = Math.floor(this.minutes / 60);
    if (minutes < 0) hourChange * -1;
    minutes = minutes < 0 ? 60 + minutes : minutes;

    let hours = (this.hours + hourChange) % 24;
    hours = hours < 0 ? 24 + hours : hours;

    this.hours = hours;
    this.minutes = minutes;
  }
}

const zeroPad = (input: number, amount: number) =>
  String(input).padStart(amount, "0");
