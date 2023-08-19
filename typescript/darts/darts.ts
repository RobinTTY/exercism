export function score(x: number, y: number): number {
  const origin = new Point(0, 0);
  const hit = new Point(x, y);
  const distance = getDistance(origin, hit);

  return distance <= 1 ? 10 : distance <= 5 ? 5 : distance <= 10 ? 1 : 0;
}

class Point {
  x: number;
  y: number;

  constructor(x: number, y: number) {
    this.x = x;
    this.y = y;
  }
}

const getDistance = (a: Point, b: Point) => {
  return Math.sqrt(Math.pow(a.x + b.x, 2) + Math.pow(a.y + b.y, 2));
};
