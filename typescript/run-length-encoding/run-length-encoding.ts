export function encode(text: string): string {
  return text.replace(
    /(.)\1+/g,
    (match) => { return `${match.length}${match[0]}` }
  )
}

export function decode(text: string): string {
  return text.replace(
    /(\d+)(\D)/g,
    (_, num, char) => { return char.repeat(num) }
  )
}
