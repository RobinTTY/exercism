export class Rational {
  numerator: number;
  denominator: number;

  constructor(numerator: number, denominator: number) {
    this.numerator = numerator;
    this.denominator = denominator;
    this.reduce();
  }

  add(rational: Rational): Rational {
    return new Rational(
      this.numerator * rational.denominator +
        rational.numerator * this.denominator,
      this.denominator * rational.denominator
    );
  }

  sub(rational: Rational): Rational {
    return new Rational(
      this.numerator * rational.denominator -
        rational.numerator * this.denominator,
      this.denominator * rational.denominator
    );
  }

  mul(rational: Rational): Rational {
    return new Rational(
      this.numerator * rational.numerator,
      this.denominator * rational.denominator
    );
  }

  div(rational: Rational): Rational {
    if (rational.numerator === 0) throw new Error("Division by 0");
    return new Rational(
      this.numerator * rational.denominator,
      rational.numerator * this.denominator
    );
  }

  abs(): Rational {
    return new Rational(Math.abs(this.numerator), Math.abs(this.denominator));
  }

  exprational(exponent: number): Rational {
    if (exponent > 0)
      return new Rational(
        this.numerator ** exponent,
        this.denominator ** exponent
      );

    exponent = Math.abs(exponent);
    return new Rational(
      this.denominator ** exponent,
      this.numerator ** exponent
    );
  }

  expreal(real: number): number {
    return Math.pow(real ** this.numerator, 1 / this.denominator);
  }

  reduce(): Rational {
    const gcd = Math.abs(this._gcd(this.numerator, this.denominator));
    this.numerator /= gcd;
    this.denominator /= gcd;

    // Place minus sign on numerator if on denominator
    this.numerator =
      this.denominator < 0 ? this.numerator * -1 : this.numerator;
    this.denominator = Math.abs(this.denominator);

    return this;
  }

  private _gcd(a: number, b: number): number {
    return !b ? a : this._gcd(b, a % b);
  }
}
