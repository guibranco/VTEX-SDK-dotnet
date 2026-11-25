// @ts-check

/** @type {import("@docusaurus/types").Config} */
const config = {
  title: "VTEX SDK",
  tagline: "Documentation for VTEX SDK",
  url: "https://guibranco.github.io",
  baseUrl: "/VTEX-SDK-dotnet/",
  onBrokenLinks: "throw",
  markdown: {
    hooks: {
      onBrokenMarkdownLinks: "warn",
    },
  },
  favicon: "img/logo.png",
  organizationName: "guibranco",
  projectName: "VTEX-SDK-dotnet",
  trailingSlash: false,

  presets: [
    [
      "classic",
      /** @type {import("@docusaurus/preset-classic").Options} */
      ({
        docs: {
          editUrl: "https://github.com/guibranco/VTEX-SDK-dotnet/tree/main/docs/",
        },
        blog: false,
      }),
    ],
  ],

  /** @type {import("@docusaurus/preset-classic").ThemeConfig} */
  themeConfig: {
    navbar: {
      title: "VTEX SDK",
      logo: {
        alt: "VTEX Logo",
        src: "img/logo.png",
      },
      items: [
        {to: "/docs/intro", label: "Docs", position: "left"},
        {
          href: "https://github.com/guibranco/VTEX-SDK-dotnet",
          label: "GitHub",
          position: "right",
        },
      ],
    },
  },
};

module.exports = config;
