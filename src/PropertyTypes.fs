module PropertyTypes

let propertyTypes =
    [ "amplitude", "float"
      "amplitude", "int"
      "ariaAtomic", "bool"
      "ariaBusy", "bool"
      "ariaChecked", "bool"
      "ariaDisabled", "bool"
      "ariaExpanded", "bool"
      "ariaGrabbed", "bool"
      "ariaHasPopup", "bool"
      "ariaHidden", "bool"
      "ariaInvalid", "bool"
      "ariaLevel", "int"
      "ariaMultiLine", "bool"
      "ariaMultiSelectable", "bool"
      "ariaPressed", "bool"
      "ariaPosInSet", "int"
      "ariaReadOnly", "bool"
      "ariaRequired", "bool"
      "ariaSelected", "bool"
      "ariaValueMax", "float"
      "ariaValueMax", "int"
      "ariaValueMin", "float"
      "ariaValueMin", "int"
      "ariaValueNow", "float"
      "ariaValueNow", "int"
      "ariaSetSize", "int"
      "async", "bool"
      "autoFocus", "bool"
      "autoPlay", "bool"
      "azimuth", "float"
      "azimuth", "int"
      "baseFrequency", "float"
      "baseFrequency", "int"
      "bias", "float"
      "bias", "int"
      "by", "float"
      "by", "int"
      "capture", "bool"
      "cols", "int"
      "colSpan", "int"
      "contentEditable", "bool"
      "controls", "bool"
      "cx", "float"
      "cx", "int"
      "cy", "float"
      "cy", "int"
      "defaultChecked", "bool"
      "defaultValue", "bool"
      "defaultValue", "float"
      "defaultValue", "int"
      "defer", "bool"
      "diffuseConstant", "float"
      "diffuseConstant", "int"
      "disabled", "bool"
      "divisor", "float"
      "divisor", "int"
      "download", "bool"
      "draggable", "bool"
      "dx", "float"
      "dx", "int"
      "dy", "float"
      "dy", "int"
      "elevation", "float"
      "elevation", "int"
      "exponent", "float"
      "exponent", "int"
      "fillOpacity", "float"
      "fillOpacity", "int"
      "fontSize", "float"
      "fontSize", "int"
      "from", "float"
      "from", "int"
      "fr", "float"
      "fr", "int"
      "fx", "float"
      "fx", "int"
      "fy", "float"
      "fy", "int"
      "hidden", "bool"
      "height", "float"
      "height", "int"
      "high", "float"
      "high", "int"
      "id", "int"
      "intercept", "float"
      "intercept", "int"
      "isChecked", "bool"
      "isOpen", "bool"
      "k1", "float"
      "k1", "int"
      "k2", "float"
      "k2", "int"
      "k3", "float"
      "k3", "int"
      "k4", "float"
      "k4", "int"
      "key", "int"
      "limitingConeAngle", "float"
      "limitingConeAngle", "int"
      "loop", "bool"
      "low", "float"
      "low", "int"
      "max", "float"
      "max", "int"
      "maxLength", "int"
      "min", "float"
      "min", "int"
      "minLength", "int"
      "multiple", "bool"
      "muted", "bool"
      "nomodule", "bool"
      "numOctaves", "int"
      "offset", "float"
      "offset", "int"
      "optimum", "float"
      "optimum", "int"
      "order", "int"
      "overlinePosition", "float"
      "overlinePosition", "int"
      "overlineThickness", "float"
      "overlineThickness", "int"
      "pathLength", "int"
      "playsInline", "bool"
      "pointsAtX", "float"
      "pointsAtX", "int"
      "pointsAtY", "float"
      "pointsAtY", "int"
      "pointsAtZ", "float"
      "pointsAtZ", "int"
      "preserveAlpha", "bool"
      "r", "float"
      "r", "int"
      "radius", "float"
      "radius", "int"
      "readOnly", "bool"
      "required", "bool"
      "rows", "int"
      "rowSpan", "int"
      "rx", "float"
      "rx", "int"
      "ry", "float"
      "ry", "int"
      "scale", "float"
      "scale", "int"
      "seed", "float"
      "seed", "int"
      "selected", "bool"
      "selectionStart", "int"
      "selectionEnd", "int"
      "size", "int"
      "spam", "int"
      "spellcheck", "bool"
      "specularConstant", "float"
      "specularConstant", "int"
      "specularExponent", "float"
      "specularExponent", "int"
      "stdDeviation", "float"
      "stdDeviation", "int"
      "step", "float"
      "step", "int"
      "stopOpacity", "float"
      "stopOpacity", "int"
      "strikethroughPosition", "float"
      "strikethroughPosition", "int"
      "strikethroughThickness", "float"
      "strikethroughThickness", "int"
      "strokeWidth", "float"
      "strokeWidth", "int"
      "surfaceScale", "float"
      "surfaceScale", "int"
      "text", "float"
      "text", "int"
      "textLength", "float"
      "textLength", "int"
      "to", "float"
      "to", "int"
      "underlinePosition", "float"
      "underlinePosition", "int"
      "underlineThickness", "float"
      "underlineThickness", "int"
      "value", "bool"
      "value", "float"
      "value", "int"
      "valueOrDefault", "bool"
      "valueOrDefault", "float"
      "valueOrDefault", "int"
      "values", "float"
      "values", "int"
      "width", "float"
      "width", "int"
      "x", "float"
      "x", "int"
      "x1", "float"
      "x1", "int"
      "x2", "float"
      "x2", "int"
      "y", "float"
      "y", "int"
      "y1", "float"
      "y1", "int"
      "y2", "float"
      "y2", "int"
      "z", "float"
      "z", "int" ]
    |> List.groupBy fst
    |> List.map (fun (name, values) -> name, values |> List.map snd)
    |> Map.ofList