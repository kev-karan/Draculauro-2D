# 🧛 Draculauro 2D

![Capa do Jogo](Assets/_external/CAPA%20FODA.png)

**Draculauro 2D** é um jogo de plataformas desenvolvido em **Unity** como parte do processo seletivo **FORJA Select**.

## 🎓 Sobre o Projeto (FORJA Select)

Este projeto foi desenvolvido para o **FORJA Select**, o processo de ingresso de novas equipes na **FORJA Game Studio**, uma iniciativa de pré-aceleração de jogos indie da **CESAR School**.

### 🎯 O Desafio: Trilha de Programação
Optei pela **Trilha de Programação**, cujo desafio consistia em recriar um jogo-modelo, demonstrando:
* Domínio sobre a Unity Engine.
* Capacidade de implementação de mecânicas de plataforma 2D.
* Organização e clareza no código (C#).
* Uso do novo sistema de Input da Unity.

## 🎮 Mecânicas do Jogo

Neste desafio, o jogador controla o vampiro **Draculauro**, que deve atravessar cenários perigosos.

* **Sistema de Fases:** Progressão através de 3 níveis (`Fase-1`, `Fase-2`, `Fase-3`).
* **Coleta de Sangue & Porta:** O objetivo principal é coletar todas as bolsas de sangue (`CollectableBlood`) do cenário.
* **Indicador Visual (Cruz):** As fases terminam numa porta trancada marcada por uma **Cruz**. Ao coletar todo o sangue, a **cruz se inverte**, indicando que a porta está destrancada e o jogador pode avançar.
* **Obstáculos Letais:** O contato com **Alhos** reinicia a fase imediatamente (`GarlicRestart`), exigindo precisão nos pulos.
* **Movimentação:** Sistema de física ajustado para plataforma (pulo, movimentação lateral e detecção de chão).

## 🛠️ Tecnologias e Implementação

* **Engine:** Unity 2022 LTS
* **Linguagem:** C#
* **Input:** Unity Input System (New)
* **Arquitetura:**
    * `GameManager`: Singleton que gerencia a contagem de sangue e valida a condição de vitória.
    * `FinishPoint`: Controla a lógica da porta e a rotação visual da cruz (`UnlockDoor`).
    * `UIManager`: Atualiza a interface com a contagem de itens coletados.

## 📂 Estrutura do Repositório

* `Assets/Scenes`: Cenas do Menu Principal e das 3 Fases jogáveis.
* `Assets/Scripts`: Todo o código fonte desenvolvido para o desafio.
* `Assets/Prefabs`: Prefabs configurados do Jogador, Inimigos e Plataformas.
* `Assets/_external`: Sprites e assets visuais utilizados.

## 🚀 Como Executar

Para avaliar o projeto localmente:

1.  Certifique-se de ter o **Unity Hub** instalado.
2.  Clone este repositório:
    ```bash
    git clone https://github.com/kev-karan/Draculauro-2D.git
    ```
3.  Adicione o projeto no Unity Hub e abra-o (versão recomendada: 2022.x).
4.  Abra a cena `Menu` localizada em `Assets/Scenes`.
5.  Pressione **Play** no editor.

## 👨‍💻 Créditos

Desenvolvido por **Kelwin Karan** para o processo seletivo da FORJA Game Studio (CESAR School).  
Artes feitas por [**Ana Flavia**](https://www.instagram.com/anacarvalhorf/).
