# Flowbite Blazor Icons


### 480+ SVG [Flowbite icons](https://github.com/themesberg/flowbite-icons) components for Blazor. 



## Original source

[themesberg/flowbite-icons](https://github.com/themesberg/flowbite-icons)

## License



[Flowbite Icons License](https://github.com/themesberg/flowbite-icons/blob/main/LICENSE)


## Requirements

Even though these icons were built forTailwind, this library does not require Tailwind or importing any CSS. All that is needed is referencing the library, then using the right namespaces and components. 

## Usage 

Any atributes attached to the components will be attached to the underlying element. Height, width, text color, stroke color, etc. can all be defined for these components.

Use the Flowbite.Icons.Outline namespace to find components based on the outline icons.

```razor
@using Flowbite.Icons.Outline
     
<ParagraphOutline class="w-6 h-6"></ParagraphOutline>
               
```

Use the Flowbite.Icons.Solid namespace to find components based on the solid icons.

```razor
@using Flowbite.Icons.Solid 

<PaperPlaneSolid class="w-6 h-6"></PaperPlaneSolid>

```

Use the Flowbite.Icons namespace for the FlowbiteIcon component which can be used for outline and solid components by defining their Type and Name.

```razor
@using Flowbite.Icons

<FlowbiteIcon Type="Outline" Name="address-book" class="w-6 h-6"></FlowbiteIcon>

```