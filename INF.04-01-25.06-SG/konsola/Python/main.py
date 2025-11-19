from random import randint

SET_LENGTH = 6
MIN_NUM = 1
MAX_NUM = 49

def generate_num_sets(count):
    sets = []
    for i in range(count):
        new_set = []
        while len(new_set) < SET_LENGTH:
            new_num = randint(MIN_NUM, MAX_NUM)
            if not new_num in new_set:
                new_set.append(new_num)
        sets.append(new_set)
    return sets

def print_num_sets(num_sets):
    print("Zestawy wylosowanych liczb:")
    i = 1
    for num_set in num_sets:
        print(f"Losowanie {i}: {' '.join(map(str, num_set))}")
        i +=1
    occurs = {}
    for j in range(MIN_NUM, MAX_NUM+1):
        occurs[j] = 0
    for num_set in num_sets:
        for num in num_set:
            occurs[num] += 1
    for num in occurs:
        print(f"Wystąpienia liczby {num}: {occurs[num]}")

if __name__ == '__main__':
    amount = int(input("Ile wygenerować losowań?\n"))
    generated = generate_num_sets(amount)
    print_num_sets(generated)