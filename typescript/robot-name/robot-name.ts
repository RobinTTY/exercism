export class Robot {
  private static reservedNames: string[] = [];

  private _nameLength = 5;
  private _name: string;

  constructor() {
    this._name = this.getDistinctName();
  }

  private generateName = () => {
    const characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    const charactersLength = characters.length;
    const numbers = "0123456789";
    const numbersLength = numbers.length;

    let result = "";
    for (let i = 0; i < this._nameLength; i++) {
      if (i < 2)
        result += characters.charAt(
          Math.floor(Math.random() * charactersLength)
        );
      else result += numbers.charAt(Math.floor(Math.random() * numbersLength));
    }

    return result;
  };

  private getDistinctName = (): string => {
    let name = this.generateName();
    while (Robot.reservedNames.includes(name)) {
      name = this.generateName();
    }
    Robot.reservedNames.push(name);

    return name;
  };

  public get name(): string {
    return this._name;
  }

  public resetName(): void {
    this._name = this.getDistinctName();
  }

  public static releaseNames(): void {
    Robot.reservedNames = [];
  }
}
