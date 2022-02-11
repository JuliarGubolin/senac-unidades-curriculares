//Cria o contole
var $navLink = $('.nav-link');

//evento para o controle
$navLink.on('click', function (evento) {
    evento.preventDefault();
    navegarParaAncora(this.hash);
});

//Função
function navegarParaAncora(ancora) {
    //Verificação: se tem uma âncora
    if (ancora !== "") {
        $('html, body').animate({
            scrollTop: $(ancora).offset().top
        }, 500, function () {
            //Vai até a âncora
            window.location.hash = ancora;
        })
    }
}

//Evento para inicialização da página
$(document).ready(function () {
    //alert("teste");
    //Configuração do OWL-Carousel
    $(".owl-carousel").owlCarousel({
        items: 4,
        loop: true,
        margin: 10,
        autoplay: true,
        autoplayTimeout: 1000,
        autoplayHoverPause: true
    });

    //Configuração Magnific-popup
    $('.image-link').magnificPopup({ type: 'image' });
});