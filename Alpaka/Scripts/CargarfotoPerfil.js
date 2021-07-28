function onFileSelected(event) {
    var selectedFile = event.target.files[0];
    var reader = new FileReader();

    var imgtag = document.getElementById("imagen");
    imgtag.title = selectedFile.name;

    reader.onload = function (event) {
        imgtag.src = event.target.result;
    };

    reader.readAsDataURL(selectedFile);
}
function CargarFotoAdmin(url) {
    $(document).ready(function () { $("#imagen").attr("src", url); })
    console.log(url);



}