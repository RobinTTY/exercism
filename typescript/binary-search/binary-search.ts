export function find(haystack: number[], needle: number): number | never {
  const result = binarySearch(haystack, needle);
  if (result !== null) return result;
  else throw new Error("Value not in array");
}

const binarySearch = (
  array: number[],
  target: number,
  start = 0,
  end = array.length - 1
): number | null => {
  const mid = Math.floor((start + end) / 2);

  if (target === array[mid]) {
    return mid;
  }

  if (start >= end) {
    return null;
  }

  return target < array[mid]
    ? binarySearch(array, target, start, mid - 1)
    : binarySearch(array, target, mid + 1, end);
};
