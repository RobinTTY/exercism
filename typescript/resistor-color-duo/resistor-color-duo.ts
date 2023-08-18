export function decodedValue(params: string[]): number {
  return (
    params
      // max 2 colors
      .slice(0, 2)
      // map the color to its index
      .map((color) => COLORS.indexOf(color))
      // accumulates the value by multiplying by 10 and adding the next value
      .reduce((acc, val) => acc * 10 + val)
  );
}

export const COLORS: string[] = [
  "black",
  "brown",
  "red",
  "orange",
  "yellow",
  "green",
  "blue",
  "violet",
  "grey",
  "white",
];
