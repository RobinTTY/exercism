export class Matrix {
  matrix: string;

  constructor(matrix: string) {
    this.matrix = matrix;
  }

  get rows(): number[][] {
    return this.matrix
      .split("\n")
      .map((nums) => nums.split(" ").map((row) => +row));
  }

  get columns(): number[][] {
    return this.rows.map((firstIteration, index) =>
      this.rows.map((secondIteration) => secondIteration[index])
    );
  }
}
