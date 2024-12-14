n = 7
A = [[0] * n for _ in range(n)]

def fill_matrix_anticlockwise():
    value = 1
    top, bottom, left, right = 0, n - 1, 0, n - 1

    while value <= n * n:
        for i in range(top, bottom + 1):
            if value <= n * n:
                A[i][left] = value
                value += 1
        left += 1

        for i in range(left, right + 1):
            if value <= n * n:
                A[bottom][i] = value
                value += 1
        bottom -= 1

        for i in range(bottom, top - 1, -1):
            if value <= n * n:
                A[i][right] = value
                value += 1
        right -= 1

        for i in range(right, left - 1, -1):
            if value <= n * n:
                A[top][i] = value
                value += 1
        top += 1

def print_matrix():
    for row in A:
        print("\t".join(map(str, row)))

fill_matrix_anticlockwise()
print_matrix()
