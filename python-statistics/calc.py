import matplotlib.pyplot as plt
import pandas as pd

tipPDF = False #bool que decide o tipo a ser salvo

df = pd.read_csv('dadosPaises.csv') #dataFrame que recebe a tabela de dados
df = df.sort_values(by=['Casos Ativos'], ascending=False) #ordena pela coluna 'casos ativos' de forma descendente
df2 = df[:5] # Separa em um novo dataframe as 5 primeiras linhas

plt.bar(df2['Dados do País'],df2['Casos Ativos'],color='r') #cria o grafico de barras (nomes,valores)
plt.ylabel('Quantidade de casos ativos') #label do eixo y

#Se true, o tipo selecionado sera pdf, senao png
if tipPDF:
	nomFig = 'grafico.pdf'
else :
	nomFig = 'grafico.png'

plt.savefig(nomFig) #salva a imagem (poder ser salvo como pdf mudando o nome do arquivo
