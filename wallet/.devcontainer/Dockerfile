# Use .NET 10 SDK for the devcontainer environment
FROM mcr.microsoft.com/dotnet/sdk:10.0

# Optional common tools you may need during container dev
RUN apt-get update && apt-get install -y --no-install-recommends \
    bash \
    git \
    curl \
    wget \
    unzip \
    lsb-release \
    procps \
    && rm -rf /var/lib/apt/lists/*

# Set working directory inside container to workspace mount path
WORKDIR /workspace

# Avoid permission issues with shared volume on Windows
RUN groupadd --gid 1000 vscode && useradd --uid 1000 --gid vscode --shell /bin/bash --create-home vscode
USER vscode
