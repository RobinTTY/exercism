export function toRna(dna: string) {
  const dnaToRna = new Map([
    ["G", "C"],
    ["C", "G"],
    ["T", "A"],
    ["A", "U"],
  ]);

  if (dna.match(/[^GCTA]/)) throw new Error("Invalid input DNA.");
  // spread operator to convert string to array of characters, map over each character, and join back into a string
  return [...dna].map((nucleotide) => dnaToRna.get(nucleotide)).join("");
}
