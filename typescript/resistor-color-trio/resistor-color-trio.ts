const ColorAry = [
  `black`,
  `brown`,
  `red`,
  `orange`,
  `yellow`,
  `green`,
  `blue`,
  `violet`,
  `grey`,
  `white`,
] as const;

// Type for the color array
export type Color = (typeof ColorAry)[number];

const ohms = [
  [1_000_000_000, "giga"],
  [1_000_000, "mega"],
  [1_000, "kilo"],
] as const;

export function decodedResistorValue([band1, band2, band3]: Color[]): string {
  // Get the number from the first two bands, then multiply by the third band
  let num =
    (ColorAry.indexOf(band1) * 10 + ColorAry.indexOf(band2)) *
    10 ** ColorAry.indexOf(band3);

  // Find the first divisor that is less than or equal to the number
  const [divisor, prefix] = ohms.find(([divisor]) => num >= divisor) ?? [1, ""];

  // Return the number divided by the divisor and the prefix
  return `${num / divisor} ${prefix}ohms`;
}
