# coding=<utf-8>
import matplotlib.pyplot as plt
import numpy as np
import pandas as pd

class calc:
	def grafCasosAtivos(tipPDF):
		"""Cria um grafico com os paises com mais casos ativos"""

		df = pd.read_csv('dadosPaises.csv') #dataFrame que recebe a tabela de dados
		df = df.sort_values(by=['Casos Ativos'], ascending=False) #ordena pela coluna 'casos ativos' de forma descendente
		df2 = df[:5] # Separa em um novo dataframe as 5 primeiras linhas

		fig, ax = plt.subplots()

		index = np.arange(len(df2['Casos Ativos'])) #indice para definir as posicoes dos labels
		bar_width = 0.45
		score_label = np.arange(0,42000,3000)
		bar = ax.bar(index, df2['Casos Ativos'], bar_width, label='Casos Ativos',color='#ff4500')
		
		#setting axis labels
		ax.set_xticks(index) #distancia entre barras
		ax.set_xticklabels(df2['Dados do País']) #label das barras
		ax.set_yticks(score_label) #distancia entre marcas do eixo y
		ax.set_yticklabels(score_label) #labels das marcas do eixo y

		ax.legend() #legenda
		
		#plt.bar(df2['Dados do País'],df2['Casos Ativos'],color='r') #cria o grafico de barras (nomes,valores)
		#plt.ylabel('Quantidade de casos ativos') #label do eixo y

		#Se true, o tipo selecionado sera pdf, senao png
		if tipPDF:
			nomFig = 'grafico.pdf'
		else :
			nomFig = 'grafico.png'	
		plt.savefig(nomFig) #salva a imagem (poder ser salvo como pdf mudando o nome do arquivo

	def grafMortes(tipPDF):
		"""Cria um grafico com paises com mais mortes acumuladas"""

		df = pd.read_csv('dadosPaises.csv') #dataFrame que recebe a tabela de dados
		df = df.sort_values(by=['Quantidade de Mortes'], ascending=False) #ordena pela coluna 'casos ativos' de forma descendente
		df2 = df[:5] # Separa em um novo dataframe as 5 primeiras linhas

		plt.bar(df2['Dados do País'],df2['Quantidade de Mortes'],align='center', alpha=0.5)
		plt.ylabel('Quantidade de Mortos')
		plt.title('Paises com mais mortes')

		if tipPDF:
			nomFig = 'grafico2.pdf'
		else :
			nomFig = 'grafico2.png'
		
		plt.savefig(nomFig)

#TestDriver
calc.grafCasosAtivos(True)
print(calc.grafCasosAtivos.__doc__)
plt.clf()
calc.grafMortes(True)
print(calc.grafMortes.__doc__)