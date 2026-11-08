
lucide.createIcons();

// ---- Mobile Menu ----
const menuToggle = document.getElementById('menuToggle');
const menuClose = document.getElementById('menuClose');
const mobileMenu = document.getElementById('mobileMenu');
const mobileLinks = document.querySelectorAll('.mobile-link');

menuToggle.addEventListener('click', () => mobileMenu.classList.add('active'));
menuClose.addEventListener('click', () => mobileMenu.classList.remove('active'));
mobileLinks.forEach(link => link.addEventListener('click', () => mobileMenu.classList.remove('active')));

// ---- Scroll Reveal ----
const observerOptions = { threshold: 0.1, rootMargin: '0px 0px -50px 0px' };

const observer = new IntersectionObserver((entries) => {
    entries.forEach(entry => {
        if (entry.isIntersecting) {
            entry.target.classList.add('revealed');
            observer.unobserve(entry.target);
        }
    });
}, observerOptions);

document.querySelectorAll('.scroll-reveal').forEach(el => observer.observe(el));

// ---- Counter Animation ----
const counterObserver = new IntersectionObserver((entries) => {
    entries.forEach(entry => {
        if (entry.isIntersecting) {
            const el = entry.target;
            const target = parseInt(el.dataset.target);
            let current = 0;
            const increment = target / 60;

            const timer = setInterval(() => {
                current += increment;

                if (current >= target) {
                    current = target;
                    clearInterval(timer);
                }

                if (el.dataset.target === '98' || el.dataset.target === '100') {
                    el.textContent = Math.round(current) + '%';
                } else {
                    el.textContent = Math.round(current) + '+';
                }
            }, 25);

            counterObserver.unobserve(el);
        }
    });
}, { threshold: 0.5 });

document.querySelectorAll('.counter-value').forEach(el => counterObserver.observe(el));

// ---- Gallery Filter ----
const filterBtns = document.querySelectorAll('.filter-btn');
const galleryItems = document.querySelectorAll('.gallery-item');

filterBtns.forEach(btn => {
    btn.addEventListener('click', () => {
        filterBtns.forEach(b => {
            b.classList.remove('active', 'bg-white/5', 'text-white');
            b.classList.add('text-neutral-500');
        });

        btn.classList.add('active', 'bg-white/5', 'text-white');
        btn.classList.remove('text-neutral-500');

        const filter = btn.dataset.filter;

        galleryItems.forEach(item => {
            const categories = (item.dataset.category || '').split(/\s+/);

            if (filter === 'all' || categories.includes(filter)) {
                item.style.display = 'block';
                item.style.opacity = '0';
                item.style.transform = 'translateY(20px)';

                setTimeout(() => {
                    item.style.transition = 'all 0.5s ease';
                    item.style.opacity = '1';
                    item.style.transform = 'translateY(0)';
                }, 50);
            } else {
                item.style.transition = 'all 0.3s ease';
                item.style.opacity = '0';
                item.style.transform = 'translateY(20px)';

                setTimeout(() => {
                    item.style.display = 'none';
                }, 300);
            }
        });
    });
});

// ---- Lightbox ----
const lightbox = document.getElementById('lightbox');
const lightboxImg = document.getElementById('lightboxImg');
const lightboxTitle = document.getElementById('lightboxTitle');
const lightboxDesc = document.getElementById('lightboxDesc');

function openLightbox(el) {
    const img = el.querySelector('img');
    const title = el.querySelector('h4');
    const desc = el.querySelector('p');

    lightboxImg.src = img.src.replace('/800/600', '/1400/1050');
    lightboxTitle.textContent = title ? title.textContent : '';
    lightboxDesc.textContent = desc ? desc.textContent : '';

    lightbox.classList.add('active');
    document.body.style.overflow = 'hidden';
}

function closeLightbox(e) {
    if (e.target === lightbox || e.currentTarget.tagName === 'BUTTON') {
        lightbox.classList.remove('active');
        document.body.style.overflow = '';
    }
}

document.addEventListener('keydown', (e) => {
    if (e.key === 'Escape' && lightbox.classList.contains('active')) {
        lightbox.classList.remove('active');
        document.body.style.overflow = '';
    }
});

// ---- Contact Form / Web3Forms ----
const contactForm = document.getElementById('contactForm');
const toast = document.getElementById('toast');

contactForm.addEventListener('submit', async (e) => {
    e.preventDefault();

    if (!contactForm.reportValidity()) return;

    const submitBtn = contactForm.querySelector('button[type="submit"]');
    const originalContent = submitBtn.innerHTML;

    submitBtn.disabled = true;
    submitBtn.innerHTML = `
        <svg class="animate-spin w-4 h-4" viewBox="0 0 24 24">
            <circle cx="12" cy="12" r="10" stroke="currentColor" stroke-width="3" fill="none" opacity="0.3"/>
            <path d="M12 2a10 10 0 0 1 10 10" stroke="currentColor" stroke-width="3" fill="none" stroke-linecap="round"/>
        </svg>
        Envoi en cours...
    `;

    try {
        const formData = new FormData(contactForm);

        formData.append('access_key', 'ca5f7542-1f95-4729-9bf6-0df00ab969c1');
        formData.append('subject', 'Nouvelle demande de devis - PFR');
        formData.append('from_name', 'Provence Façade Rénovation');

        const response = await fetch('https://api.web3forms.com/submit', {
            method: 'POST',
            body: formData
        });

        const result = await response.json();

        if (!response.ok || !result.success) {
            throw new Error(result.message || 'Erreur lors de l’envoi.');
        }

        // Envoi réussi
        toast.classList.add('show');
        setTimeout(() => toast.classList.remove('show'), 4000);

        contactForm.reset();

    } catch (error) {
        console.error('Web3Forms error:', error);

        alert(
            'Impossible d’envoyer votre demande. Veuillez réessayer ou nous contacter directement.'
        );

    } finally {
        submitBtn.innerHTML = originalContent;
        submitBtn.disabled = false;

        if (typeof lucide !== 'undefined') {
            lucide.createIcons();
        }
    }
});

// ---- Navbar background on scroll ----
const nav = document.querySelector('nav > div > div');
window.addEventListener('scroll', () => {
    if (window.scrollY > 100) {
        nav.style.background = 'rgba(243,236,220,0.96)';
        nav.style.borderColor = 'rgba(36,31,23,0.15)';
    } else {
        nav.style.background = 'rgba(243,236,220,0.9)';
        nav.style.borderColor = 'rgba(36,31,23,0.1)';
    }
});