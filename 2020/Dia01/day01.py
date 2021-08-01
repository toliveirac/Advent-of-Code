## Desafio AdventOfCode Natal de 2020

entrada = r"C:\Python\AdventOfCode\2020\Dia01\input.txt"
arquivo = open(entrada, mode='r').read()

lista = arquivo.split(sep='\n')

def encontra_saida():
    for pos in enumerate(lista):
        v_referencia = int(pos[1])
        for v_a_somar in enumerate(lista):
            if int(v_a_somar[1]) + v_referencia == 2020:
                saida = int(v_a_somar[1]) * v_referencia
                return saida
    return "sem valor compativel"

if __name__ == '__main__':
    print(encontra_saida())