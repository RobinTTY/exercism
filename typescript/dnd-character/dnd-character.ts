export class DnDCharacter {
  public hitpoints: number;
  public constitution: number;
  public strength: number;
  public dexterity: number;
  public charisma: number;
  public wisdom: number;
  public intelligence: number;

  constructor() {
    this.constitution = DnDCharacter.generateAbilityScore();
    this.strength = DnDCharacter.generateAbilityScore();
    this.dexterity = DnDCharacter.generateAbilityScore();
    this.charisma = DnDCharacter.generateAbilityScore();
    this.wisdom = DnDCharacter.generateAbilityScore();
    this.intelligence = DnDCharacter.generateAbilityScore();
    this.hitpoints = 10 + DnDCharacter.getModifierFor(this.constitution);
  }

  public static generateAbilityScore(): number {
    const randomValues: number[] = [];

    for (let n = 0; n < 4; n++) {
      randomValues.push(getRandomDice());
    }

    return randomValues
      .sort((a, b) => b - a)
      .slice(0, 3)
      .reduce((acc, val) => acc + val);
  }

  public static getModifierFor(abilityValue: number): number {
    return Math.floor((abilityValue - 10) / 2);
  }
}

const getRandomDice = (): number => Math.floor(Math.random() * 6);
