Deverá ser CRIADO um aplicativo utilizando os conhecimentos adquiridos ao longo do semestre,  seguindo as instruções abaixo.

O aplicativo terá como objetivo gerenciamento de veículos em um estacionamento, com o  objetivo registrar a entrada e saída de veículos.

Requisitos:
-Banco de dados: SQLite
-Arquitetura: MVC
-Plataforma: .NET MAUI
-Navegação: Shell

O Aplicativo deve conter 3 telas.

1 - Menu Principal (Shell Navigation)
-Menu lateral (hambúrguer)
-Imagem temática no topo
-Nome do aplicativo em destaque
-Itens de navegação:
->Cadastro de Veículos: redireciona para a tela de cadastro de veículos
->Estacionamento: exibe os registros cadastrados e os filtros
-No rodapé do menu, deve constar:
->Versão do aplicativo (ex: v1.0.0)
->Nome dos participantes do grupo

2 – Tela de Cadastro
-Tela com visual temático do estacionamento.
-Deve conter, no mínimo, os seguintes campos (todos obrigatórios):
->Placa
->Marca
->Modelo
->Cor
->Nome Proprietário
->Tipo: Mensalista ou Diario
->Foto do Veiculo(imagem selecionável)
->Data e hora da entrada (preenchida automaticamente)
-Regras:
->Ao digitar uma placa já cadastrada, os campos devem ser preenchidos automaticamente com os dados existentes
-Validação: não deve ser possível salvar um registro com informações em branco
-Botão Salvar: deve gravar os dados no banco de dados e apresentar uma mensagem ao usuário indicando sucesso ou erro na operação

3 – Tela de Listagem
-Tela com visual temático do estacionamento.
-Filtros:
->Placa
->Data
->Status pagamento(Pago ou Não)
->OBS: Os filtros devem funcionar de forma combinada (por exemplo: buscar placa X em uma data Y e se está pago)
-Lista(ListView):
->Placa
->Marca
->Modelo
->Cor
->Nome do proprietário
->Data de entrada
->Se houver, exibir Data de saída abaixo da data de entrada
->Ícones de ação:
==>Ícone de pagamento(Saída): Marca o veículo como pago.
==>Funcionalidade: Ao clicar no ícone, o status do carrinho será alternado entre “pago” e “não pago”, deverá registrar o horário do pagamento como horário da saída.
==>Ícone de lixeira (Exclusão de registro): Permite remover o registro do banco de dados.
==>Funcionalidade: Ao clicar no ícone, o aplicativo deve solicitar uma antes de excluir definitivamente o registro.  

Todas as telas precisão ser coesas com o tema da aplicação e utilizar dos conceitos de UX/UI.

No máximo 3(TRÊS) integrantes por grupo.
Realizar um vídeo explicativo(deve ter áudio) do funcionamento total do sistema.
Apenas um participante deve realizar a entrega da solicitação.
ANEXAR O VÍDEO (DIRETAMENTE NO CLASSROOM).
Anexar a pasta do projeto compactada.
INFORMAR O NOME DOS PARTICIPANTES NOS COMENTÁRIOS PARTICULARES DURANTE O ANEXO DOS ARQUIVOS.
NÃO DEIXE PARA REALIZAR A ENTREGA NO ULTIMO MINUTO.
DATA MÁXIMA DA ENTREGA: 20/06/2025
NÃO SERÁ ACEITO ENTREGAS APÓS A DATA MAXIMA ESTIPULADA ACIMA.
