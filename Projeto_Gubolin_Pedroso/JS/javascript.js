var $navMenu = $('.nav-menu');
var $sobreNos = $('#sobre-nos');

//funcao que muda o comportamento padrao da tag a (link)
function navegarParaAncora(ancora) {
    //verificacao se tem uma ancora
    if (ancora !== "") {
        $('html, body').animate({
            scrollTop: $(ancora).offset().top
        }, 300, function () {
            //vai até ancora
            window.location.hash = ancora;
        });
    }
}

//funcoes de exibir fotos
function exibeFotos(id) {
    alert(id);
    var galeria1 = ['foto1.jpg', 'foto2.jpg'];

    if (id == 3) {
        for (var i = 0; i < galeria1.length; i++) {
            console.log(galeria1[i]);
        }
    }
}
//evento para o controle
$navMenu.on('click', function (evento) {
    evento.preventDefault();
    navegarParaAncora(this.hash);
});
