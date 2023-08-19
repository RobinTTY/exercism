export class GradeSchool {
  private _roster: Record<number, string[]>;
  private _uniqueStudents: string[];

  constructor() {
    this._roster = {};
    this._uniqueStudents = [];
  }

  roster() {
    return structuredClone(this._roster);
  }

  add(name: string, grade: number) {
    if (!this._roster[grade]) this._roster[grade] = [];
    if (this._uniqueStudents.includes(name)) {
      // search the right grade by value (not efficient, maybe a map would have been more appropriate)
      let grade = Object.keys(this._roster)
        .map(Number)
        .find((key) =>
          this._roster[key].some((student) => student === name)
        ) as number;
      this._roster[grade].splice(this._roster[grade].indexOf(name), 1);
    }
    this._roster[grade].push(name);
    this._uniqueStudents.push(name);
    this._roster[grade].sort();
  }

  print() {
    console.log(this._uniqueStudents);
  }

  grade(grade: number) {
    return this._roster[grade] ? structuredClone(this._roster[grade]) : [];
  }
}
