def binary_array_to_number(arr):
 # Преобразуем массив единиц и нулей в строку
    binary_string = ''.join(str(bit) for bit in arr)
    # Преобразуем двоичную строку в целое число
    integer_value = int(binary_string, 2)
    return integer_value