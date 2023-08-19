export function hey(message: string): string {
  message = message.trim();
  if (message.isUpperCase() && message.lastElementisQuestionMark())
    return "Calm down, I know what I'm doing!";
  else if (message.isUpperCase()) return "Whoa, chill out!";
  else if (message.lastElementisQuestionMark()) return "Sure.";
  else if (message === "") return "Fine. Be that way!";
  else return "Whatever.";
}

declare global {
  interface String {
    isUpperCase(): boolean;
    lastElementisQuestionMark(): boolean;
  }
}

String.prototype.isUpperCase = function (this: string): boolean {
  const alphabet = [
    "a",
    "b",
    "c",
    "d",
    "e",
    "f",
    "g",
    "h",
    "i",
    "j",
    "k",
    "l",
    "m",
    "n",
    "o",
    "p",
    "q",
    "r",
    "s",
    "t",
    "u",
    "v",
    "w",
    "x",
    "y",
    "z",
  ];
  if (
    this.toLowerCase()
      .split("")
      .some((letter) => alphabet.includes(letter))
  )
    return this === this.toUpperCase();
  else return false;
};

String.prototype.lastElementisQuestionMark = function (this: string): boolean {
  return this.slice(-1) === "?";
};
