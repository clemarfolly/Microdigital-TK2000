# Microdigital - TK2000

<p align="center">
    <img  height="200" src="https://github.com/user-attachments/assets/b7c42dfb-7c5d-46b4-8caf-4119a7e99b1b">
</p>

A Microdigital Eletrônica Ltda foi uma das empresas pioneiras no mercado de microcomputadores no Brasil, tendo grande importância na popularização da informática durante a década de 1980. Fundada em 1979, a empresa se destacou por criar e distribuir uma série de microcomputadores compatíveis com modelos internacionais. A Microdigital se beneficiou da reserva de mercado imposta pelo governo brasileiro, o que levou a empresa a desenvolver produtos que atendessem à demanda interna por tecnologia, educação e entretenimento.

Entre os produtos está o TK2000, lançado oficialmente em 1984 após ser apresentado na Feira de Informática de 1983. Inspirado no Apple II, o TK2000 foi um microcomputador voltado para o mercado doméstico e educacional, parcialmente compatível com o software do Apple II, mas com algumas limitações em termos de hardware, o que o tornava mais acessível ao consumidor brasileiro. Equipado com uma CPU 6502, 16k de ROM e 64k de RAM, o TK2000 era, na verdade, um clone do Micro-Professor MPF-II, um modelo taiwanês fabricado pela Multitech (futura Acer). O sucesso do TK2000 consolidou a Microdigital como uma das líderes no mercado de microcomputadores no Brasil, contribuindo significativamente para a difusão da cultura computacional no país durante os anos 80. Em 1985, foi lançada uma versão aprimorada, o TK2000 II, que incluía uma opção de 128K de memória. O microcomputador foi descontinuado em 1987.

## Sobre essa reprodução

<p align="center">
    <img height="200" src="https://github.com/user-attachments/assets/0bce09c0-2e63-4d3a-b3ec-127e16f080e1">
</p>

A reprodução do projeto foi realizada sem acesso físico à placa original, com base em fotos encontradas na internet. Para isso, utilizou-se os software Sprint Layout e o KiCad para desenhar o esquema e a placa de circuito impresso. A réplica ainda não foi produzida, e seu funcionamento não foi validado. Agradecemos às pessoas que disponibilizaram as fotos e o esquema original, permitindo que esse trabalho fosse possível.

 ### Datalhes da placa
A placa é dupla face e o tamanho final ficou com 237x170 mm.

<p align="center">
  <img height="250" src="https://github.com/user-attachments/assets/b929285a-dc39-40ad-9baa-c7ed39590151" hspace="20">
  <img height="250" src="https://github.com/user-attachments/assets/beae97be-41e8-4d71-9df0-1ffe6181d6e7" hspace="20">
</p>

### Comparação com a placa original
Embora eu não tenha tido acesso direto à placa original, me esforcei para que a recriação fosse a mais fiel possível. Algumas imagens de referência estavam em baixa resolução e precisaram ter suas proporções ajustadas, além de estarem com componentes e adesivos, o que dificultou a reprodução das trilhas que passavam por baixo deles.

<p align="center">
    <img height="200" src="https://github.com/user-attachments/assets/daf8d63f-add9-4cba-a503-e511ff91c387">
</p>

A parte de RF foi removida e no lugar colocada uma saída de áudio. Além disso, o jumper que conecta o pino 28 da ROM U39 ao pino 7 do 74LS244 foi integrado diretamente ao roteamento da placa, permetindo o uso de uma ROM 27C128.

### Para confecção

Na seção de releases desta página, você encontrará todos os arquivos necessários para a fabricação da placa: o gerber em formato zip, o esquema em PDF e a lista interativa de materiais em HTML. Basta enviar o arquivo zip para a sua fabricante de PCB de preferência.

### Chip customizado

A montagem requer a gravação de um chip PLD GAL16V8, o conteúdo está na pasta PAL. Mais detalhes em: 

https://www.facebook.com/groups/cidadedosclassicos/posts/5769043533153302/?paipv=0&eav=AfbpHolPJ6P4nDAmXXkvS--qkC2yUR-xJ5SVl_j7wmNv-nLbxHa_C_v81FATnQMoCv0&_rdr

## Créditos

### Recriação da Placa: 

Clemar Folly Jr.

https://x.com/clemarfolly/ - https://www.facebook.com/clemarjr

### Fotos

Clube do TK90X

http://www.tk90x.com.br/Projetos_TK2000_clareamento.html

José Ferro - Recebido via E-mail

Tabajara Labs

http://tabalabs.com.br/tk2k/reparo_teclado/

Grupo Microdigital TK 2000 no Facebook

https://www.facebook.com/groups/2839171526116039/

Uma saída de som para o TK2000

https://www.victortrucco.com/TK/TK2000Som/TK2000Som

### Esquema

TK2000 - Esquema Elétrico Placa Principal - Datassette

https://datassette.org/manuais/hardware-tk-2000-microdigital-eletronica-manuais/tk2000-esquema-eletrico-placa-principal

#### Caso queira contribuir para que outras reproduções como esta sejam feitas, considere fazer uma doação.

Chave pix: clemarjr@gmail.com
