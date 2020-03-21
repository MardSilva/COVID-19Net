import matplotlib.pyplot as plt
import pandas as pd

df = pd.read_csv('dadosPaises.csv') #dataFrame que recebe a tabela de dados
df = df.sort_values(by=['Casos Ativos'], ascending=False) #ordena pela coluna 'casos ativos' de forma descendente
df2 = df[:5] # Separa em um novo dataframe as 5 primeiras linhas

plt.bar(df2['Dados do País'],df2['Casos Ativos']) #cria o grafico de barras (nomes,valores)
plt.ylabel('Quantidade de casos ativos') #label do eixo y
plt.savefig('grafico.png') #salva a imagem
