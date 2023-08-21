export function commands(num: number): string[] {
  const commands: string[] = [];
  const binary = convertToBinary(num);

  if (binary[binary.length - 1] === "1") commands.push("wink");
  if (binary[binary.length - 2] === "1") commands.push("double blink");
  if (binary[binary.length - 3] === "1") commands.push("close your eyes");
  if (binary[binary.length - 4] === "1") commands.push("jump");
  if (binary[binary.length - 5] === "1") commands.reverse();
  return commands;
}

function convertToBinary(num: number): string {
  return (num >>> 0).toString(2);
}
