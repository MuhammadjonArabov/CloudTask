def binary_to_decimal(binary_str):
    try:
        decimal_number = int(binary_str, 2)
        return decimal_number
    except ValueError:
        return "Iltimos, faqat 0 va 1 raqamlaridan iborat son kiriting."

if __name__ == "__main__":
    binary_input = input("Ikkilik sonni kiriting: ")
    result = binary_to_decimal(binary_input)
    print(f"10 lik sanoq sistemasidagi qiymati: {result}")