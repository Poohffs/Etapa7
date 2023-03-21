function agendar(){
    var campoNome = document.getElementById('nome')
    var campoEmail = document.getElementById('email')
    var campoMensagem = document.getElementById('mensagem')


    if(campoNome.value == 0){
        alert('Preencha todo os campos para realizar a solicitação!');
        campoNome.focus();
    } else if(campoMensagem.value == 0){
        alert('Preencha todo os campos para realizar a solicitação!');
        campoMensagem.focus();
    } else if(campoEmail.value == 0){
        alert('Preencha todo os campos para realizar a solicitação!');
        campoEmail.focus();
    } else {
        alert('Pedido de agendamento realizado, aguardar confirmação sobre dia e horario pelo e-mail enviado!');
        return true
    }
    }

    var slideIndex = 1;
var slideIndex2 = 0;
//showSlides(slideIndex);
showSlidesAutomatic();

// Controle de Próximo/Anterior
function plusSlides(n) {
  showSlides(slideIndex += n);
}

// Controles de imagem em miniatura
function currentSlide(n) {
  showSlides(slideIndex = n);
}

// Função para exibir as imagens
function showSlides(n) {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("dot");
  if (n > slides.length) { slideIndex = 1 }
  if (n < 1) { slideIndex = slides.length }
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }
  for (i = 0; i < dots.length; i++) {
    dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex - 1].style.display = "block";
  dots[slideIndex - 1].className += " active";
}

function showSlidesAutomatic() {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("dot");
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }
  slideIndex2++;
  if (slideIndex2 > slides.length) { slideIndex2 = 1 }

  for (i = 0; i < dots.length; i++) {
    dots[i].className = dots[i].className.replace(" active", "");
  }

  slides[slideIndex2 - 1].style.display = "block";
  dots[slideIndex2 - 1].className += " active";
  setTimeout(showSlidesAutomatic, 2000);
}
