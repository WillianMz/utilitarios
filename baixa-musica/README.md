# WILLIAN YouTube MP3 Downloader

Aplicativo desenvolvido em Python para baixar o áudio de vídeos ou playlists do YouTube e convertê-los automaticamente para MP3 utilizando **yt-dlp** e **FFmpeg**.

---

# Requisitos

* Windows 10 ou Windows 11
* Python 3.14 ou superior
* Pip (instalado junto com o Python)

---

# Instalação das dependências

Abra o Prompt de Comando na pasta do projeto e execute:

```cmd
py -m pip install yt-dlp
py -m pip install pyinstaller
```

Verifique se tudo foi instalado corretamente:

```cmd
py -m pip show yt-dlp
py -m PyInstaller --version
```

---

# Estrutura do projeto

A estrutura recomendada é:

```text
baixa-musica/
│
├── baixa.py
├── ffmpeg/
│   ├── ffmpeg.exe
│   ├── ffprobe.exe
│   └── LICENSE (opcional)
│
└── README.md
```

Os arquivos **ffmpeg.exe** e **ffprobe.exe** são obrigatórios para que o programa consiga converter o áudio para MP3.

---

# Executando durante o desenvolvimento

Para executar diretamente pelo Python:

```cmd
py baixa.py
```

---

# Gerando o executável

Apague versões antigas (caso existam):

```cmd
rmdir /s /q build
rmdir /s /q dist
del baixa.spec
```

Depois gere o executável:

```cmd
py -m PyInstaller ^
--onefile ^
--windowed ^
--add-data "ffmpeg;ffmpeg" ^
baixa.py
```

Ao terminar serão criadas duas pastas:

```text
build
dist
```

O executável estará em:

```text
dist\baixa.exe
```

---

# Como funciona

O programa realiza as seguintes etapas:

1. Recebe um link de vídeo ou playlist do YouTube.
2. Baixa o melhor áudio disponível usando o **yt-dlp**.
3. Utiliza o **FFmpeg** para converter o áudio para MP3.
4. Salva o arquivo na mesma pasta onde o programa foi executado.

---

# Problemas comuns

## Erro:

```text
ModuleNotFoundError: No module named 'yt_dlp'
```

### Solução

Instale o pacote:

```cmd
py -m pip install yt-dlp
```

---

## Erro:

```text
Postprocessing: ffmpeg not found
```

ou

```text
Postprocessing: ffprobe not found
```

### Solução

Verifique se a estrutura está correta:

```text
ffmpeg/
├── ffmpeg.exe
└── ffprobe.exe
```

---

## Erro:

```text
Failed to find a suitable install for 'pyinstaller'
```

### Solução

O comando correto é:

```cmd
py -m pip install pyinstaller
```

e não:

```cmd
py install pyinstaller
```

---

## O comando "pyinstaller" não é reconhecido

Use sempre:

```cmd
py -m PyInstaller
```

Esse método funciona mesmo quando a pasta Scripts não está adicionada ao PATH do Windows.

---

# Atualizando o yt-dlp

Para manter o programa compatível com alterações do YouTube:

```cmd
py -m pip install --upgrade yt-dlp
```

---

# Atualizando o PyInstaller

```cmd
py -m pip install --upgrade pyinstaller
```

---

# Distribuição

O executável criado na pasta `dist` pode ser copiado para outro computador.

Não é necessário instalar Python no computador de destino.

Caso o FFmpeg tenha sido incluído durante a geração do executável, também não será necessário instalar o FFmpeg.

---

# Dicas

Para reduzir problemas futuros:

* Mantenha o yt-dlp sempre atualizado.
* Utilize uma versão recente do FFmpeg.
* Gere novamente o executável sempre que atualizar as dependências.

---

# Comandos úteis

Instalar dependências:

```cmd
py -m pip install yt-dlp
py -m pip install pyinstaller
```

Executar o programa:

```cmd
py baixa.py
```

Gerar o executável:

```cmd
py -m PyInstaller --onefile --windowed --add-data "ffmpeg;ffmpeg" baixa.py
```

Atualizar o yt-dlp:

```cmd
py -m pip install --upgrade yt-dlp
```

Atualizar o PyInstaller:

```cmd
py -m pip install --upgrade pyinstaller
```

---

# Licenças

Este projeto utiliza bibliotecas de terceiros:

* Python
* yt-dlp
* FFmpeg

Cada uma possui sua própria licença de uso.

---

# Autor

**WillianMz**

2026
