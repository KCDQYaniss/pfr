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
                    const suffix = (el.dataset.target === '98' || el.dataset.target === '100') ? '%' : '+';
                    const timer = setInterval(() => {
                        current += increment;
                        if (current >= target) {
                            current = target;
                            clearInterval(timer);
                        }
                        el.textContent = Math.round(current) + suffix;
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
                    b.classList.remove('active', 'bg-[#B5652E]/20', 'text-[#241F17]');
                    b.classList.add('text-[#7A6E58]');
                });
                btn.classList.add('active', 'bg-[#B5652E]/20', 'text-[#241F17]');
                btn.classList.remove('text-[#7A6E58]');

                const filter = btn.dataset.filter;

                galleryItems.forEach(item => {
                    if (filter === 'all' || item.dataset.category === filter) {
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
                        setTimeout(() => { item.style.display = 'none'; }, 300);
                    }
                });
            });
        });

        // ---- Lightbox / Carousel ----
        const lightbox = document.getElementById('lightbox');
        const lightboxImg = document.getElementById('lightboxImg');
        const lightboxTitle = document.getElementById('lightboxTitle');
        const lightboxDesc = document.getElementById('lightboxDesc');
        const lightboxCounter = document.getElementById('lightboxCounter');
        const lightboxDots = document.getElementById('lightboxDots');
        const lightboxPrev = document.getElementById('lightboxPrev');
        const lightboxNext = document.getElementById('lightboxNext');

        let carouselImages = [];
        let carouselIndex = 0;

        function renderCarouselImage() {
            if (!carouselImages.length) return;
            lightboxImg.src = carouselImages[carouselIndex];

            const multiple = carouselImages.length > 1;
            lightboxPrev.style.display = multiple ? 'flex' : 'none';
            lightboxNext.style.display = multiple ? 'flex' : 'none';

            lightboxCounter.textContent = multiple ? `${carouselIndex + 1} / ${carouselImages.length}` : '';
            lightboxCounter.style.display = multiple ? 'block' : 'none';

            lightboxDots.innerHTML = '';
            if (multiple) {
                carouselImages.forEach((_, i) => {
                    const dot = document.createElement('span');
                    dot.className = 'lightbox-dot' + (i === carouselIndex ? ' active' : '');
                    dot.addEventListener('click', (e) => {
                        e.stopPropagation();
                        carouselIndex = i;
                        renderCarouselImage();
                    });
                    lightboxDots.appendChild(dot);
                });
            }
        }

        function nextLightboxImage(e) {
            if (e) e.stopPropagation();
            if (!carouselImages.length) return;
            carouselIndex = (carouselIndex + 1) % carouselImages.length;
            renderCarouselImage();
        }

        function prevLightboxImage(e) {
            if (e) e.stopPropagation();
            if (!carouselImages.length) return;
            carouselIndex = (carouselIndex - 1 + carouselImages.length) % carouselImages.length;
            renderCarouselImage();
        }

        function openLightbox(el) {
            const img = el.querySelector('img');
            const title = el.querySelector('h4');
            const desc = el.querySelector('p');

            let images = [];
            if (el.dataset.images) {
                try { images = JSON.parse(el.dataset.images); } catch (err) { images = []; }
            }
            // Fallback: if no predefined carousel images are set, just show the thumbnail
            carouselImages = images.length ? images : [img.src];
            carouselIndex = 0;

            lightboxTitle.textContent = title ? title.textContent : '';
            lightboxDesc.textContent = desc ? desc.textContent : '';

            renderCarouselImage();
            lightbox.classList.add('active');
            document.body.style.overflow = 'hidden';
        }

        function closeLightbox(e) {
            if (e.target === lightbox || e.currentTarget.tagName === 'BUTTON' || e.currentTarget.closest?.('button')) {
                lightbox.classList.remove('active');
                document.body.style.overflow = '';
            }
        }

        document.addEventListener('keydown', (e) => {
            if (!lightbox.classList.contains('active')) return;
            if (e.key === 'Escape') {
                lightbox.classList.remove('active');
                document.body.style.overflow = '';
            } else if (e.key === 'ArrowRight') {
                nextLightboxImage();
            } else if (e.key === 'ArrowLeft') {
                prevLightboxImage();
            }
        });

        // ---- Contact Form (Web3Forms) ----
        const contactForm = document.getElementById('contactForm');
        const toast = document.getElementById('toast');
        const toastIcon = document.getElementById('toastIcon');
        const toastTitle = document.getElementById('toastTitle');
        const toastText = document.getElementById('toastText');
        let toastTimer;

        function showToast(ok, title, text) {
            toastIcon.innerHTML = `<i data-lucide="${ok ? 'check-circle' : 'alert-circle'}" class="w-5 h-5"></i>`;
            toastTitle.textContent = title;
            toastText.textContent = text;
            lucide.createIcons();
            toast.classList.add('show');
            clearTimeout(toastTimer);
            toastTimer = setTimeout(() => toast.classList.remove('show'), 4000);
        }

        contactForm.addEventListener('submit', async (e) => {
            e.preventDefault();

            const submitBtn = contactForm.querySelector('button[type="submit"]');
            const originalContent = submitBtn.innerHTML;
            submitBtn.innerHTML = '<svg class="animate-spin w-4 h-4" viewBox="0 0 24 24"><circle cx="12" cy="12" r="10" stroke="currentColor" stroke-width="3" fill="none" opacity="0.3"/><path d="M12 2a10 10 0 0 1 10 10" stroke="currentColor" stroke-width="3" fill="none" stroke-linecap="round"/></svg> Envoi en cours...';
            submitBtn.disabled = true;

            try {
                const response = await fetch(contactForm.action, {
                    method: 'POST',
                    headers: { 'Accept': 'application/json' },
                    body: new FormData(contactForm)
                });
                const result = await response.json();

                if (response.ok && result.success) {
                    contactForm.reset();
                    showToast(true, 'Demande envoyée !', 'Nous vous recontactons sous 48h.');
                } else {
                    throw new Error(result.message || 'Erreur Web3Forms');
                }
            } catch (err) {
                console.error('Envoi du formulaire échoué :', err);
                showToast(false, 'Envoi impossible', 'Réessayez ou appelez-nous au 06.25.28.49.23.');
            } finally {
                submitBtn.innerHTML = originalContent;
                submitBtn.disabled = false;
                lucide.createIcons();
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