# Fabricação — Microdigital TK2000 (Rev. 2)

Esta pasta reúne os arquivos necessários para **fabricar a placa de circuito impresso** da réplica do TK2000.

Ela é somente o pacote de **fabricação**: os arquivos de entrada para enviar ao fabricante de PCB e a lista de compras de componentes. O projeto completo (esquema, layout, fotos e firmware do PLD) está no repositório raiz.

| Arquivo | O que é |
|---|---|
| `Microdigital-TK2000_Rev2.zip` | Os **Gerbers X2** e os arquivos de furação (Excellon) para fabricação da placa. É este arquivo que se envia à fábrica. |
| `Microdigital-TK2000_Rev2.html` | A **BOM interativa** (Interactive BOM do KiCad). Abrir no navegador para comprar e montar componente por componente. |

Ambos os arquivos são **autocontidos** (funcionam offline) e foram gerados com KiCad 7.0.11 / iBOM v2.12.0.

---

## 1. O que está dentro do ZIP

Placa **dupla face**, **236,9 × 169,9 mm** (~237 × 170 mm), 1249 pads, **1831 furos metalizados** + 1 não metalizado.

| Arquivo | Camada / Função |
|---|---|
| `TK2000-F_Cu.gtl` | Cobre, face superior (L1) |
| `TK2000-B_Cu.gbl` | Cobre, face inferior (L2) |
| `TK2000-F_Mask.gts` / `TK2000-B_Mask.gbs` | Máscara de solda, topo / verso |
| `TK2000-F_Paste.gtp` / `TK2000-B_Paste.gbp` | Pasta de solda, topo / verso |
| `TK2000-F_Silkscreen.gto` / `TK2000-B_Silkscreen.gbo` | Legenda (serigrafia), topo / verso |
| `TK2000-Edge_Cuts.gm1` | Contorno da placa (perfil de corte) |
| `TK2000-PTH.drl` | Furação metalizada (1831 furos, 11 diâmetros: 0,6 a 3,5 mm) |
| `TK2000-NPTH.drl` | Furação não metalizada (1 furo de 2,7 mm) |
| `TK2000-PTH-drl_map.gbr` / `TK2000-NPTH-drl_map.gbr` | Mapa de furação (só conferência na fábrica, não é para fabricar) |

Para produzir a placa, envie o `.zip` **inteiro** — a maioria das fábricas não consegue reconstituir o conjunto a partir de arquivos soltos.

---

## 2. A BOM interativa (o que você realmente vai usar para montar)

Abra o `Microdigital-TK2000_Rev2.html` no navegador. É um arquivo único, sem internet, com a lista de componentes do lado esquerdo e o **desenho da placa do lado direito**. As duas telas são sincronizadas:

- **Clicar numa linha da tabela** destaca os componentes no desenho da placa (e vice-versa).
- **Clicar num componente no desenho** rola a tabela até a linha correspondente.
- **Caixas de seleção `Sourced` e `Placed`** — uma para "comprado" e outra para "montado". Conforme você vai marcando, o menu mostra o progresso (`X de 205`). O estado fica salvo no navegador, então dá para retomar a montagem depois.
- **Botão `Copy`** copia a tabela inteira para a área de transferência; no menu há **Export/Import** para salvar e recuperar o progresso, e **Save as csv/txt** para gerar a lista de compras.
- **Filtros de visualização** (Tracks, Zones, Pads, Silkscreen, Values, References, Dark mode) ajudam a enxergar o que está embaixo de cada componente.
- **`Ref lookup`** — digite `R23` e ele aponta a posição do componente na placa.

### Resumo da lista

**82 grupos / 205 componentes** (4 elementos gráficos, como logos, foram excluídos da lista).

| Categoria | Qtd. | Observações |
|---|---|---|
| CIs (DIP) | 50 | CPU **6502** (U29), 8 × **4116** (16 KB de RAM), 2 × **2764** (ROM), **PAL14L4** em U41, 37 × 74LSxx, LM741 |
| Resistores | 53 | Majoritariamente horizontais (`Resistor_P12.7mm_Horizontal`) |
| Capacitores | 34 | 22 × 100 nF, 2 × 100 µF, 47 µF, 1 µF, alguns "pequenos" a definir |
| Diodos / LED | 13 | 2 × 1N4148, 1 × zener 5V1, 1 × LED, 9 genéricos `D_Small` |
| Transistores | 8 | 5 × BC548, 2 × BD140, 1 × BF494B |
| Jumpers de solda | 17 | **6 já vêm fechados (é preciso soldar)**, 11 abertos (opcionais/configuráveis) |
| Conectores | 12 | POWER e **Joystick** (DB-9), MONITOR / AUDIO (RCA), EAR, MIC, controles remotos A/B, alto-falante (AMP), expansão (2×25), P3 (2×08), P5 |
| Cristal / indutor | 2 | Cristal (Y1) e indutor 47 µH (L1) |
| Furos de montagem | 8 | H1–H8 (⌀2,7 e ⌀3,5 mm) |
| Pontos de teste | 8 | TP1, TP3, TP4, TP6–TP10 |

⚠ **Valores indefinidos no projeto:** `C64` e `R67`, `R72`, `R73`, `R74` estão marcados com `"?"` na BOM. Consulte o esquema (`EsquemaKiCad/Microdigital-TK2000_Rev2.pdf`) antes de comprar. Os campos `D_Small` (9 diodos), `C_Small` (5) e `C_Polarized_Small` (2) são placeholders: escolha o componente que couber no footprint e na tensão de trabalho.

---

## 3. Passo a passo para construir sua réplica

1. **Estude a BOM aberta no navegador.** Antes de gastar dinheiro, entenda o que a placa faz e salve o PDF do esquema da pasta `EsquemaKiCad`.
2. **Peça a placa.** Envie o `Microdigital-TK2000_Rev2.zip` a um fabricante de PCB. As especificações estão todas nos metadados dos arquivos: 2 camadas, ~237 × 170 mm, 1 furo não metalizado de 2,7 mm. Verifique o *preview* da camada cobre antes de aprovar a produção.
3. **Compre os componentes.** Use os botões `Save as csv` / `Copy` da BOM para gerar a lista de compras. Componentes TTL ativos (`74LSxx`), 4116, 2764, BD140 e PAL podem demorar — comece por eles.
4. **Grave o chip customizado.** O `PAL14L4` (U41) não vem gravado de fábrica. O conteúdo está na pasta [`PAL`](../PAL) do repositório (`TK2000_PAL.zip`); grave com um programador de PLD antes de instalar o CI no socket.
5. **Monte a placa.** Soldar os componentes verificando a **silk screen** e usando o desenho interativo como referência. Marque `Sourced`/`Placed` no HTML conforme avança — o acompanhamento fica salvo no navegador.
6. **Configure os jumpers.** 6 jumpers precisam ser **soldados (fechados)** de fábrica; os 11 abertos são opções de configuração. Confira no esquema/na BOM o que cada um seleciona.
7. **Valide.** Ligue em uma fonte com limite de corrente e siga os pontos de teste `TP1`–`TP10`. **Atenção:** esta réplica ainda não foi produzida nem testada em campo — nada aqui foi comprovado em funcionamento. Comece pela alimentação/clock/reset, depois CPU e RAM, e só então vídeo, teclado e áudio.

### Notas de projeto relevantes

- A parte de **RF foi removida** e substituída por uma **saída de áudio** (`T7 / AUDIO`), usando a ideia publicada por [Victor Trucco](https://www.victortrucco.com/TK/TK2000Som/TK2000Som).
- O jumper que ligava o pino 28 da ROM `U39` ao pino 7 do `74LS244` foi **incorporado ao roteamento**, permitindo o uso de uma ROM **27C128** em vez de 2764.
- A placa foi redesenhada a partir de **fotos** (sem acesso ao original físico), então podem existir diferenças em relação ao TK2000 de fábrica.

---

## Créditos

Recriação da placa: **Clemar Folly Jr.** — <https://x.com/clemarfolly> · <https://www.facebook.com/clemarjr>
Fotos, esquema original e referências: Clube do TK90X, José Ferro, Tabajara Labs e Grupo Microdigital TK 2000 (veja o [README do projeto](../README.md)).