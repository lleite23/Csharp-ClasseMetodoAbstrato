# CsharpClasseMetodoAbstrato
Programa que exibe taxas com base em tipos de produtos (importado, usado ou comum)

Este programa exibe informações polimórficas de acordo com o tipo de objeto declarado para a variável genérica Produto (super classe abstrata/ método abstrato).

Usuário informa a quantidade de produtos (dado do tipo int)
Informa o tipo de produto (Comum, usado ou importado - 'c/u/i') (dado do tipo char - apenas a letra inicial)
Com base na escolha do tipo de produto, são solicitadas informações diferentes
Comum: Nome (varchar) e preço (double com duas casas decimais separadas por ponto .)
Usado: Nome (varchar) e preço (double com duas casas decimais separadas por ponto .) e data de fabricação (formato dd/mm/aaaa)
Importado: Nome (varchar) e preço (double com duas casas decimais separadas por ponto .) e valor da taxa de importação (double com duas casas decimais separadas por ponto .)

É criada uma lista e adicionado a ela, a variável do tipo Produto com os objetos comum, usado ou importado, com base na informação do usuário.
No final, é exibida de modo polimórfico o resultado com base na sobrescrição de cada método das subclasses.

