export function isIsogram(phrase: string): boolean {
  let alphabet = 'abcdefghijklmnopqrstuvwxyz';
  let buffer: string[] = [];
  let phraseArr = phrase.toLowerCase().split('');

  for(let i = 0; i < phraseArr.length; i++) {
    if(buffer.includes(phraseArr[i]))
      return false;
    if(alphabet.includes(phraseArr[i]))
      buffer.push(phraseArr[i]);
  }
  
  // TODO: Why does this not work?
  // phraseArr.forEach((letter) => {
  //   if(buffer.includes(letter))
  //     return false;
  //   if (alphabet.includes(letter))
  //     buffer.push(letter);
  // });

  return true;
}
