## Web Mvc Test
### Opção de filtro no campo de seleção, utilizando Jquery e Selected2.

![image](https://user-images.githubusercontent.com/55838972/150059553-746789cd-24ef-4fbe-8095-264d1ff8c40a.png)

```html

<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/select2@4.0.13/dist/css/select2.min.css" />

<div class="text-center">
    <h5 class="display-4">Dropdownlist</h5>
    <p>
        <select id="tableSelect" class="drop">           
        </select>
    </p>
</div>

@section Scripts
{
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript" src="https://cdn.jsdelivr.net/npm/select2@4.0.13/dist/js/select2.min.js"></script>
    <script type="text/javascript">
        $(() => {
            $.ajax({
                url: "@Url.Action("Registros", "home")",
                dataType: "json",
                type: "GET",
                success: function (result) {
                    var optionhtml1 = '<option value="' + 0 + '">' + "--Selecione--" + '</option>';
                    $("#tableSelect").append(optionhtml1);
                    $.each(result.data.registros, function (i) {
                        var optionhtml = '<option value="' + result.data.registros[i].id + '">' + result.data.registros[i].descricao + '</option>';
                        $("#tableSelect").append(optionhtml);
                    });
                    $("#tableSelect").select2(result.data.registros)
                },
                error: function () {
                    alert("Ops! Tente novamente...");
                }
            });
            $(function () {
                $("#tableSelect").select2();
            });
        }) 
    </script>
}

```
