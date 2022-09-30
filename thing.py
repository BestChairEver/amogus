import csv
a=int(input("Введите действие(1-чтение файла, 2-запись в файл): "))
if a==1:
    with open("list.csv", encoding='utf-8') as r_file:
        file_reader = csv.reader(r_file, delimiter = ",")
        count = 0
        for row in file_reader:
            if count == 0:
                print(f'{", ".join(row)}')
            else:
                print(f'{row[0]}, {row[1]}, {row[2]}')
            count += 1
elif a==2:
    with open("list.csv", mode="w", encoding='utf-8') as w_file:
        file_writer = csv.writer(w_file, delimiter = ",", lineterminator="\r")
        file_writer.writerow(["Имя", "Город", "Возраст"])
        file_writer.writerow(["Саша", "Ростов", "20"])
        file_writer.writerow(["Маша", "Ялта", "21"])
        file_writer.writerow(["Петя", "Москва", "15"])
        file_writer.writerow(["Амогус", "Марс", "9999"])
else:
    print("Неправильно введены даныые")